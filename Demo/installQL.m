function installQL()
%% This function installs the paths
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


dirNames={'./Controllers','./Data'};

for i=1:length(dirNames)
    addpath(dirNames{i});
end

end